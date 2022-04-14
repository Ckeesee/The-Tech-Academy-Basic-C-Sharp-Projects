namespace DateTimeWebApp.ViewModels
{
    public class DateTimeVm
    {
        public DateTime Date { get; set; }
        public DateTime Time { get; set; }

        public void CurrentDate()
        {
            Date = DateTime.Now;
        }
    }
}
