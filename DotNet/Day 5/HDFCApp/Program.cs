
using Banking;
using Notification;
using taxation;
using Taxation;
Account acct=new Account();
acct.Balance=150000;

NotificationOperation proxyEmailSender=new NotificationOperation(NotificationService.SendEmail);
NotificationOperation proxySMSSender=new NotificationOperation(NotificationService.SendSMS);
NotificationOperation proxyWhatsappSender=new NotificationOperation(NotificationService.SendWhatsAppMessage);

acct.underBalance+= proxyEmailSender;
acct.underBalance+= proxySMSSender;
acct.underBalance+= proxyWhatsappSender;



//acct.Withdraw(141000);


//Account acct45=new Account();
//attach event handler with with before working with object 
//operation

Thread currentThread=Thread.CurrentThread;
int threadId=currentThread.ManagedThreadId;
Console.WriteLine( "Primary Thread Id="+ threadId);
Console.WriteLine("Primary Thread Prioity: "+ currentThread.Priority);


Console.WriteLine( "\n \n \n  Now Event Driven Application");



TaxOperation incomeTax=new TaxOperation(TaxationService.PayIncomeTax);
acct.overBalance+= TaxationService.PayIncomeTax;
acct.overBalance+= TaxationService.PayGSTTax;

acct.overBalance+= TaxationService.PaysalesTax;
acct.overBalance+= TaxationService.PayServiceTax;
acct.Deposit(120000);

float currentBalance_2=acct.Balance;
Console.WriteLine(" Latest Balance of acct45 "+currentBalance_2);

























// NotificationOperation proxyEmailSender=new NotificationOperation(NotificationService.SendEmail);
// // NotificationOperation proxySMSSender=new NotificationOperation(NotificationService.SendSMS);
// // NotificationOperation proxyWhatAppSender=new NotificationOperation(NotificationService.SendWhatsAppMessage);

// NotificationOperation proxy=null;
// //Chaining
// acct.underBalance+=proxyEmailSender;
// // proxy+=proxySMSSender;
// // proxy+=proxyWhatAppSender;
// acct.Withdraw(141000);
