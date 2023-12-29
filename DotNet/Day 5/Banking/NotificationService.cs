namespace Notification;

public static class NotificationService{

    public static void SendEmail(string to,string content){
        Console.WriteLine("Email is sent to "+ to);
    }

     public static void SendSMS(string to,string content){
        Console.WriteLine("SMS is sent to "+ to);
    }

     public static void SendWhatsAppMessage(string to,string content){
        Console.WriteLine("Whatsapp is sent to "+ to);
    }
}