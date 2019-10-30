using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChuckNorrisAPI;

namespace ChuckNorrisForm
{
    public partial class frmGetJoke : Form
    {
        public frmGetJoke()
        {
            InitializeComponent();
        }

        private async void btnGetJoke_ClickAsync(object sender, EventArgs e)
        {
            Joke joke = await ChuckNorrisClient.GetRandomJoke();

            txtJokeDisplay.Text = joke.JokeText;
        }

        private async void frmGetJoke_LoadAsync(object sender, EventArgs e)
        {
            IEnumerable<string> categories = await ChuckNorrisClient.GetCategories();

            foreach (var cat in categories)
            {
                cbxCategories.Items.Add(cat);
            }
        }
    }
}
