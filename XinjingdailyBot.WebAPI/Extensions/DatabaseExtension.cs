using SqlSugar;
using SqlSugar.IOC;
using System.Reflection;
using XinjingdailyBot.Infrastructure;

namespace XinjingdailyBot.WebAPI.Extensions
{
    public static class DatabaseExtension
    {
        private static readonly NLog.Logger _logger = NLog.LogManager.GetCurrentClassLogger();

        private static bool IsFirstLoad = true;

        public static void AddSqlSugar(this IServiceCollection services, IConfiguration configuration)
        {
            var debug = configuration.GetValue("Debug", false);
            var dbConfig = configuration.GetSection("Database").Get<OptionsSetting.DatabaseOption>();

            if (dbConfig == null)
            {
                _logger.Error("���ݿ����ò���Ϊ��");
                Environment.Exit(1);
            }

            string connStr = dbConfig.UseMySQL ?
                $"Host={dbConfig.DbHost};Port={dbConfig.DbPort};Database={dbConfig.DbName};UserID={dbConfig.DbUser};Password={dbConfig.DbPassword};CharSet=utf8mb4;AllowZeroDateTime=true" :
                $"DataSource={dbConfig.DbName}.db";

            services.AddSqlSugar(new IocConfig()
            {
                ConfigId = 0,
                ConnectionString = connStr,
                DbType =dbConfig.UseMySQL ? IocDbType.MySql : IocDbType.Sqlite,
                IsAutoCloseConnection = true//�Զ��ͷ�
            });

            SugarIocServices.ConfigurationSugar(db =>
            {
                if (debug)
                {
                    db.Aop.OnLogExecuting = (sql, pars) =>
                    {
                        var param = db.GetConnectionScope(0).Utilities.SerializeObject(pars.ToDictionary(it => it.ParameterName, it => it.Value));

                        _logger.Info($"{sql}��{param}\n");
                    };

                    db.Aop.OnError = (e) =>
                    {
                        _logger.Error(e, $"ִ��SQL����{e.Message}");
                    };
                    //SQLִ����
                    db.Aop.OnLogExecuted = (sql, pars) =>
                    {
                        //ִ�����˿������SQLִ��ʱ��(OnLogExecutedDelegate) 
                    };
                }

                if (dbConfig.Generate && IsFirstLoad)
                {
                    _logger.Info("��ʼ�������ݿ�");
                    //�������ݿ�
                    db.DbMaintenance.CreateDatabase(dbConfig.DbName);

                    //�������ݱ�
                    Assembly assembly = Assembly.Load("TrxTradeBot.Model");
                    var types = assembly.GetTypes()
                        .Where(x => x.GetCustomAttribute<SugarTable>() != null);

                    foreach (var type in types)
                    {
                        _logger.Info($"��ʼ���� {type} ��");
                        db.CodeFirst.InitTables(type);
                    }
                }

                IsFirstLoad = false;
            });
        }
    }

}
