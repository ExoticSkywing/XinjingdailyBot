
using XinjingdailyBot.Infrastructure;
using XinjingdailyBot.WebAPI.Extensions;
using NLog.Extensions.Logging;

namespace XinjingdailyBot.WebAPI
{
    public class Program
    {
        private static readonly NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            logger.Info("Starting web host");

            //������֧��
            builder.Services.AddOptions().Configure<OptionsSetting>(builder.Configuration);

            //NLog
            builder.Services.AddLogging(loggingBuilder =>
            {
                loggingBuilder.ClearProviders();
                loggingBuilder.SetMinimumLevel(LogLevel.Debug);
                loggingBuilder.AddNLog();
            });

            //SqlSugar
            builder.Services.AddSqlSugar(builder.Configuration);

            //��ӷ���
            builder.Services.AddAppService();

            //Telegram
            builder.Services.AddTelegramBotClient();

            //Web API
            builder.Services.AddControllers();

            //Swagger
            builder.Services.AddSwagger();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}