﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace XinjingdailyBot.Infrastructure.Localization {
    using System;
    
    
    /// <summary>
    ///   一个强类型的资源类，用于查找本地化的字符串等。
    /// </summary>
    // 此类是由 StronglyTypedResourceBuilder
    // 类通过类似于 ResGen 或 Visual Studio 的工具自动生成的。
    // 若要添加或移除成员，请编辑 .ResX 文件，然后重新运行 ResGen
    // (以 /str 作为命令选项)，或重新生成 VS 项目。
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class Langs {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Langs() {
        }
        
        /// <summary>
        ///   返回此类使用的缓存的 ResourceManager 实例。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("XinjingdailyBot.Infrastructure.Localization.Langs", typeof(Langs).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   重写当前线程的 CurrentUICulture 属性，对
        ///   使用此强类型资源类的所有资源查找执行重写。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   查找类似 当前：🤔保留来源 的本地化字符串。
        /// </summary>
        public static string AnymouseOff {
            get {
                return ResourceManager.GetString("AnymouseOff", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 当前：👻匿名投稿 的本地化字符串。
        /// </summary>
        public static string AnymouseOn {
            get {
                return ResourceManager.GetString("AnymouseOn", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 您已被{0}封禁, 理由: {1}, 您将无法继续使用投稿功能和大部分命令 的本地化字符串。
        /// </summary>
        public static string BanedUserTips {
            get {
                return ResourceManager.GetString("BanedUserTips", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Copyright © 2022-2023 {0} 的本地化字符串。
        /// </summary>
        public static string Copyright {
            get {
                return ResourceManager.GetString("Copyright", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 ========================================================== 的本地化字符串。
        /// </summary>
        public static string Line {
            get {
                return ResourceManager.GetString("Line", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 没有权限 的本地化字符串。
        /// </summary>
        public static string NoPostRight {
            get {
                return ResourceManager.GetString("NoPostRight", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 ⚠️ NSFW 提前预警 ⚠️ 的本地化字符串。
        /// </summary>
        public static string NSFWWarning {
            get {
                return ResourceManager.GetString("NSFWWarning", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 ❌取消 的本地化字符串。
        /// </summary>
        public static string PostCancel {
            get {
                return ResourceManager.GetString("PostCancel", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 投稿已取消 的本地化字符串。
        /// </summary>
        public static string PostCanceled {
            get {
                return ResourceManager.GetString("PostCanceled", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 ✅投稿 的本地化字符串。
        /// </summary>
        public static string PostConfirm {
            get {
                return ResourceManager.GetString("PostConfirm", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 稿件已成功投递 的本地化字符串。
        /// </summary>
        public static string PostSendSuccess {
            get {
                return ResourceManager.GetString("PostSendSuccess", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 封禁记录自助查询: /myban 如果对封禁记录有异议, 请联系频道管理员 的本地化字符串。
        /// </summary>
        public static string QueryBanDescribe {
            get {
                return ResourceManager.GetString("QueryBanDescribe", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 无趣 的本地化字符串。
        /// </summary>
        public static string RejectBoring {
            get {
                return ResourceManager.GetString("RejectBoring", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 ↩️返回 的本地化字符串。
        /// </summary>
        public static string RejectCancel {
            get {
                return ResourceManager.GetString("RejectCancel", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 没懂 的本地化字符串。
        /// </summary>
        public static string RejectConfusing {
            get {
                return ResourceManager.GetString("RejectConfusing", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 内容不合适 的本地化字符串。
        /// </summary>
        public static string RejectDeny {
            get {
                return ResourceManager.GetString("RejectDeny", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 重复 的本地化字符串。
        /// </summary>
        public static string RejectDuplicate {
            get {
                return ResourceManager.GetString("RejectDuplicate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 模糊 的本地化字符串。
        /// </summary>
        public static string RejectFuzzy {
            get {
                return ResourceManager.GetString("RejectFuzzy", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 其他原因 的本地化字符串。
        /// </summary>
        public static string RejectOther {
            get {
                return ResourceManager.GetString("RejectOther", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 广告 的本地化字符串。
        /// </summary>
        public static string RejectQRCode {
            get {
                return ResourceManager.GetString("RejectQRCode", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 ✅采用 的本地化字符串。
        /// </summary>
        public static string ReviewAccept {
            get {
                return ResourceManager.GetString("ReviewAccept", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 ✅二频 的本地化字符串。
        /// </summary>
        public static string ReviewAcceptSecond {
            get {
                return ResourceManager.GetString("ReviewAcceptSecond", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 ✅第二频道采用 的本地化字符串。
        /// </summary>
        public static string ReviewAcceptSecondFull {
            get {
                return ResourceManager.GetString("ReviewAcceptSecondFull", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 尚未设置审核群组, 无法接收投稿 的本地化字符串。
        /// </summary>
        public static string ReviewGroupNotSet {
            get {
                return ResourceManager.GetString("ReviewGroupNotSet", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 ⏳延时 的本地化字符串。
        /// </summary>
        public static string ReviewPlan {
            get {
                return ResourceManager.GetString("ReviewPlan", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 ❌拒绝 的本地化字符串。
        /// </summary>
        public static string ReviewReject {
            get {
                return ResourceManager.GetString("ReviewReject", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 #A___ 的本地化字符串。
        /// </summary>
        public static string TagAIGraphOff {
            get {
                return ResourceManager.GetString("TagAIGraphOff", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 #AI怪图 的本地化字符串。
        /// </summary>
        public static string TagAIGraphOn {
            get {
                return ResourceManager.GetString("TagAIGraphOn", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 #我_____ 的本地化字符串。
        /// </summary>
        public static string TagFriendOff {
            get {
                return ResourceManager.GetString("TagFriendOff", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 #我有一个朋友 的本地化字符串。
        /// </summary>
        public static string TagFriendOn {
            get {
                return ResourceManager.GetString("TagFriendOn", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 #N___ 的本地化字符串。
        /// </summary>
        public static string TagNSFWOff {
            get {
                return ResourceManager.GetString("TagNSFWOff", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 #NSFW 的本地化字符串。
        /// </summary>
        public static string TagNSFWOn {
            get {
                return ResourceManager.GetString("TagNSFWOn", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 当前：🖼️禁用遮罩 的本地化字符串。
        /// </summary>
        public static string TagSpoilerOff {
            get {
                return ResourceManager.GetString("TagSpoilerOff", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 当前：⚠️开启遮罩 的本地化字符串。
        /// </summary>
        public static string TagSpoilerOn {
            get {
                return ResourceManager.GetString("TagSpoilerOn", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 #晚_ 的本地化字符串。
        /// </summary>
        public static string TagWanAnOff {
            get {
                return ResourceManager.GetString("TagWanAnOff", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 #晚安 的本地化字符串。
        /// </summary>
        public static string TagWanAnOn {
            get {
                return ResourceManager.GetString("TagWanAnOn", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 文本为空, 无法创建投稿 的本地化字符串。
        /// </summary>
        public static string TextPostCantBeNull {
            get {
                return ResourceManager.GetString("TextPostCantBeNull", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 感谢您的投稿, 审核结果将会稍后通知 的本地化字符串。
        /// </summary>
        public static string ThanksForSendingPost {
            get {
                return ResourceManager.GetString("ThanksForSendingPost", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 您已被 {0} 解封, 理由: {1}, 已恢复您的投稿和命令权限 的本地化字符串。
        /// </summary>
        public static string UnbanedUserTips {
            get {
                return ResourceManager.GetString("UnbanedUserTips", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Version: {0} - {1} 的本地化字符串。
        /// </summary>
        public static string Version {
            get {
                return ResourceManager.GetString("Version", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 您受到了一次警告, 理由: {0} 的本地化字符串。
        /// </summary>
        public static string WarnUserTips {
            get {
                return ResourceManager.GetString("WarnUserTips", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 当前累计受到警告&lt;code&gt;{0}&lt;/code&gt;次, 达到&lt;code&gt;{1}&lt;/code&gt;次后将会被系统自动封禁, 警告90天后自动消除 的本地化字符串。
        /// </summary>
        public static string WarnUserTips2 {
            get {
                return ResourceManager.GetString("WarnUserTips2", resourceCulture);
            }
        }
    }
}
