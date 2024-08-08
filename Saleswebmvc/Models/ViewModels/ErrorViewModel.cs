namespace Saleswebmvc.Models.ViewModels
{
    public class ErrorViewModel
    {
        public String RequestId { get; set; }
        public string Message { get; set; }


        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
