﻿

#pragma checksum "C:\Users\Chris\Downloads\LinkedIn OAuth 2.0 Example with WebAuthenticationBroker and PasswordVault\C#\OAuth2LinkedIn\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "73CF9CF598461D01ABD1974AE8DF828B"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OAuth2Concur
{
    partial class MainPage : global::Windows.UI.Xaml.Controls.Page
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.TextBox linkedInApiUrl; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.Button sendHttpRequestButton; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.TextBox apiQuery; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.TextBox logTextBox; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.Button getAccessTokenButton; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.Button clearAccessTokenButton; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.Button clearLogButton; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private bool _contentLoaded;

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent()
        {
            if (_contentLoaded)
                return;

            _contentLoaded = true;
            global::Windows.UI.Xaml.Application.LoadComponent(this, new global::System.Uri("ms-appx:///MainPage.xaml"), global::Windows.UI.Xaml.Controls.Primitives.ComponentResourceLocation.Application);
 
            linkedInApiUrl = (global::Windows.UI.Xaml.Controls.TextBox)this.FindName("linkedInApiUrl");
            sendHttpRequestButton = (global::Windows.UI.Xaml.Controls.Button)this.FindName("sendHttpRequestButton");
            apiQuery = (global::Windows.UI.Xaml.Controls.TextBox)this.FindName("apiQuery");
            logTextBox = (global::Windows.UI.Xaml.Controls.TextBox)this.FindName("logTextBox");
            getAccessTokenButton = (global::Windows.UI.Xaml.Controls.Button)this.FindName("getAccessTokenButton");
            clearAccessTokenButton = (global::Windows.UI.Xaml.Controls.Button)this.FindName("clearAccessTokenButton");
            clearLogButton = (global::Windows.UI.Xaml.Controls.Button)this.FindName("clearLogButton");
        }
    }
}



