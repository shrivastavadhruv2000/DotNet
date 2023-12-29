namespace Banking;

using System.Diagnostics.Tracing;
using Notification;
using Taxation;

public class Account{

  
    public event NotificationOperation underBalance;

    public event TaxOperation overBalance;
    public float Balance{get;set;}

    public void Deposit(float amount){
        this.Balance=this.Balance+amount;
        if(this.Balance>=250000){
           overBalance(5000);
           //Console.WriteLine("overbalance");
        }


    }
    public void Withdraw(float amount){
        this.Balance=this.Balance-amount;
        if(this.Balance<=10000){
            underBalance("Dhruv","Your account is blocked");
            //Console.WriteLine("underbalance");
        }

    }
}