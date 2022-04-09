namespace BridgePattern
{
    public class Program
    {
        //Send email
        //DataSender _emailSender = new EmailSender();
        //_emailSender._bridgeComponent = new WebService();
        //_emailSender.Send();

        //Send SMS
        DataSender _smsSender = new SmsSender();
        //DataSender _smsSender = new EmailSender();
        //_smsSender._bridgeComponent = new ThirdPetyAPI();
        //_smsSender.Send();
    }
}