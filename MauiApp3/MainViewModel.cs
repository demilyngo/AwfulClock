

using System;

namespace MauiApp3;


public class MainViewModel : BindableObject
{
    private DateTime _dateTime;
    private Timer _timer;
    //public MainViewModel()
    //{
    //    var timer = new Timer(state =>
    //   {
    //        OnPropertyChanged(nameof(time));
    //    }, new object(), TimeSpan.Zero, TimeSpan.FromSeconds(1));
    //}
    private string _title;

    public string Title
    {
        get => _title;
        set
        {
            if (_title == value) return;
            _title = value;
            OnPropertyChanged(nameof(Title));
        }
    }

   
    public MainViewModel()
    {

        _timer = new Timer(new TimerCallback((s) =>
            {
                //this.DateTime = DateTime.Now;
                OnPropertyChanged(nameof(time));
                OnPropertyChanged(nameof(test));
            }),
            null, TimeSpan.Zero, TimeSpan.FromSeconds(1));
    }


    public int[] time
    {
        get
        {
            var dateTime = DateTime.Now;
            return new int[6]
            {
                dateTime.Hour / 10, dateTime.Hour % 10,
                dateTime.Minute / 10, dateTime.Minute % 10,
                dateTime.Second / 10, dateTime.Second %10
            };
        }
    }

    public String test => new string(time.Select(x => x.ToString().ToCharArray()[0]).ToArray());
}
