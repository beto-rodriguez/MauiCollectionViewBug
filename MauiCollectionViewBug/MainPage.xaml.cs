namespace MauiCollectionViewBug
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = this;
        }

        public Monkey[] Monkeys { get; set; } =
            [
                new Monkey { Name = "Baboon", ImageUrl = "https://i.pinimg.com/originals/97/a9/92/97a9929f12ce116ec9a00449912cc3aa.jpg", Location = "Africa" },
                new Monkey { Name = "Capuchin Monkey", ImageUrl = "https://i.pinimg.com/originals/97/a9/92/97a9929f12ce116ec9a00449912cc3aa.jpg", Location = "Africa" },
                new Monkey { Name = "Blue Monkey", ImageUrl = "https://i.pinimg.com/originals/97/a9/92/97a9929f12ce116ec9a00449912cc3aa.jpg", Location = "Africa" },
                new Monkey { Name = "Squirrel Monkey", ImageUrl = "https://i.pinimg.com/originals/97/a9/92/97a9929f12ce116ec9a00449912cc3aa.jpg", Location = "Africa" },
                new Monkey { Name = "Golden Lion Tamarin", ImageUrl = "https://i.pinimg.com/originals/97/a9/92/97a9929f12ce116ec9a00449912cc3aa.jpg", Location = "Africa" },
            ];
    }

    public class Monkey
    {
        public required string Name { get; set; }
        public required string ImageUrl { get; set; }
        public required string Location { get; set; }
    }
}
