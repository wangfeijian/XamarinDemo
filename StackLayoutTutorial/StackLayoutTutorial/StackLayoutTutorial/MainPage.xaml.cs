using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace StackLayoutTutorial
{
    public partial class MainPage : ContentPage
    {
        public IList<Monkey> Monkeys { get; private set; }
        public MainPage()
        {
            InitializeComponent();

            Monkeys = new List<Monkey>();
            Monkeys.Add(new Monkey
            {
                Name = "Baboon",
                Location = "Africa & Asia",
                ImageUrl = "https://tse4-mm.cn.bing.net/th/id/OIP-C.F6L4QZYArku3VD4i7yvhhQHaHa?pid=ImgDet&rs=1"
            });

            Monkeys.Add(new Monkey
            {
                Name = "Capuchin Monkey",
                Location = "Central & South America",
                ImageUrl = "https://tse1-mm.cn.bing.net/th/id/OIP-C.KAI_JY2qt7zAhSOqiqBIvAHaE7?pid=ImgDet&rs=1"
            });

            Monkeys.Add(new Monkey
            {
                Name = "Blue Monkey",
                Location = "Central and East Africa",
                ImageUrl = "https://tse1-mm.cn.bing.net/th/id/OIP-C.xfP6OB7i0rhXsunGTxPSjAHaJQ?pid=ImgDet&rs=1"
            });

            Monkeys.Add(new Monkey
            {
                Name = "Squirrel Monkey",
                Location = "Central & South America",
                ImageUrl = "https://tse1-mm.cn.bing.net/th/id/OIP-C.TRD6jlGz4b2MkEI96kcgpwHaLE?pid=ImgDet&w=1500&h=2241&rs=1"
            });

            Monkeys.Add(new Monkey
            {
                Name = "Golden Lion Tamarin",
                Location = "Brazil",
                ImageUrl = "https://3sn4dm1qd6i72l8a4r2ig7fl-wpengine.netdna-ssl.com/wp-content/uploads/2017/01/conservation_goldlenliontamarin.jpg"
            });

            Monkeys.Add(new Monkey
            {
                Name = "Howler Monkey",
                Location = "South America",
                ImageUrl = "https://tse1-mm.cn.bing.net/th/id/OIP-C.G5cmNeuj8tFAFKcnmEvvLwHaF7?pid=ImgDet&rs=1"
            });

            Monkeys.Add(new Monkey
            {
                Name = "Japanese Macaque",
                Location = "Japan",
                ImageUrl = "https://ts1.cn.mm.bing.net/th/id/R-C.edd506008c6ea7bf4c3cddd600f0dce3?rik=qcKa9Y4FkTDtzw&riu=http%3a%2f%2fcdn.animalhi.com%2f3000x2000%2f20121102%2fbathing+monkeys+japanese+macaque+3000x2000+wallpaper_www.animalhi.com_80.jpg&ehk=2RM3sBfv3I%2bZd%2fqmO2aEtxaXT53O1%2fgyUVN%2bfC5iiLc%3d&risl=1&pid=ImgRaw&r=0"
            });

            Monkeys.Add(new Monkey
            {
                Name = "Mandrill",
                Location = "Southern Cameroon, Gabon, Equatorial Guinea, and Congo",
                ImageUrl = "https://www.lesdebrouillards.com/wp-content/uploads/2018/01/iStock-mandrill.jpg"
            });

            Monkeys.Add(new Monkey
            {
                Name = "Proboscis Monkey",
                Location = "Borneo",
                ImageUrl = "https://www.myholiday2.com/wp-content/uploads/2020/04/IMG_3248-scaled.jpg"
            });

            Monkeys.Add(new Monkey
            {
                Name = "Red-shanked Douc",
                Location = "Vietnam, Laos",
                ImageUrl = "https://img.brut.media/thumbnail/meet-the-red-shanked-douc-95579846-54a7-4a99-96c0-6c8bebdf4e39-square-auto.jpg?ts=1598031474"
            });

            Monkeys.Add(new Monkey
            {
                Name = "Gray-shanked Douc",
                Location = "Vietnam",
                ImageUrl = "https://ts1.cn.mm.bing.net/th/id/R-C.40e6af33c2ab633f066a66d08586d952?rik=%2bn9CMo3l68MemA&riu=http%3a%2f%2fgreenglobaltravel.com%2fwp-content%2fuploads%2fdouc_at_Philadelphia_Zoo-Art-G.jpg&ehk=JBnUZDWrjAVhCgIvSVMfHVtvqtLup1mQo%2fDiPHJSZGg%3d&risl=&pid=ImgRaw&r=0"
            });

            Monkeys.Add(new Monkey
            {
                Name = "Golden Snub-nosed Monkey",
                Location = "China",
                ImageUrl = "https://tse1-mm.cn.bing.net/th/id/OIP-C.9EDy4R3hRL1G1CV6j6meSAHaE8?pid=ImgDet&rs=1"
            });

            Monkeys.Add(new Monkey
            {
                Name = "Black Snub-nosed Monkey",
                Location = "China",
                ImageUrl = "https://ts1.cn.mm.bing.net/th/id/R-C.712c5256c46c15bd01888f99b2064348?rik=HZ%2bxFDUL0RkFMw&riu=http%3a%2f%2fi1.treknature.com%2fphotos%2f3200%2fblack_snub-nosed_monkey.jpg&ehk=ePqtniPncqmTIkaOI1HRm%2fX9fhcFstn3lrZ4SSGQITs%3d&risl=&pid=ImgRaw&r=0"
            });

            Monkeys.Add(new Monkey
            {
                Name = "Tonkin Snub-nosed Monkey",
                Location = "Vietnam",
                ImageUrl = "https://tse3-mm.cn.bing.net/th/id/OIP-C.iwyg1Qvghx_vLHB-aErbDwHaFY?pid=ImgDet&rs=1"
            });

            Monkeys.Add(new Monkey
            {
                Name = "Thomas's Langur",
                Location = "Indonesia",
                ImageUrl = "https://tse3-mm.cn.bing.net/th/id/OIP-C.JSQYc3-R3QGrCoIbrLBZ9AHaE8?pid=ImgDet&rs=1"
            });

            Monkeys.Add(new Monkey
            {
                Name = "Purple-faced Langur",
                Location = "Sri Lanka",
                ImageUrl = "https://tse2-mm.cn.bing.net/th/id/OIP-C.LmDYEbWWXMEEzLt31eQ1IAHaE9?pid=ImgDet&rs=1"
            });

            Monkeys.Add(new Monkey
            {
                Name = "Gelada",
                Location = "Ethiopia",
                ImageUrl = "https://tse1-mm.cn.bing.net/th/id/OIP-C.tRTDEKDMqKkkyqboyuK11AHaHr?pid=ImgDet&rs=1"
            });

            BindingContext = this;
        }

        private void OnButtonClicked(object sender, EventArgs e)
        {
            (sender as Button).Text = "Click Me Again!";
        }

        private void OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Monkey selectedItem = e.CurrentSelection[0] as Monkey;
        }
    }
}
