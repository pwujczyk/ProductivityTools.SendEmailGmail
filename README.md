<!--Category:Powershell--> 
 <p align="right">
    <a href="https://www.powershellgallery.com/packages/ProductivityTools.PSSetLockScreen/"><img src="Images/Header/Nuget_border_40px.png" /></a>
    <a href="http://www.productivitytools.tech/sql-commands/"><img src="Images/Header/ProductivityTools_green_40px_2.png" /><a> 
    <a href="https://www.github.com/pwujczyk/ProductivityTools.PSSetLockScreen"><img src="Images/Header/Github_border_40px.png" /></a>
</p>
<p align="center">
    <a href="http://productivitytools.tech/">
        <img src="Images/Header/LogoTitle_green_500px.png" />
    </a>
</p>

# Send-EmailGmail

Nuget simplify sending email through gmail account.

<!--more-->
<!--og-image-->

```c#
IConfigurationRoot configuration = new ConfigurationBuilder()
	.AddMasterConfiguration()
	.Build();
    
string password = configuration["GmailPassword"];
SentEmailGmail.Gmail.Send("productivitytools.tech@gmail.com", configuration["GmailPassword"], "pwujczyk@hotmail.com", "Subject", body);
```

As Google does not allow anymore less secure apps as a password you should pass **App Password**  

[Here](https://support.google.com/accounts/answer/185833/) is tutorial how to create App Password

![](Images/2022-10-02-16-44-41.png)![](Images/2022-10-02-16-44-48.png)