using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using OOP_Project_3.Core.Entities;
using OOP_Project_3.Visual;

namespace OOP_Project_3.Core
{
    public abstract class World
    {
        public VisualFormManager GameManager { get; set; }
        public Game GameForm { get; set; }
        public IEnumerable<Organism> OrganismsReadOnly => organisms;

        protected List<Organism> organisms;
        protected LinkedList<string> logs;
        protected Random randomGenerator;
        protected ValueTuple<int, int> worldSize;

        private Action enterKeyPressed;

        protected World((int, int) size, MaterialForm gameForm)
        {
            GameManager = new VisualFormManager(gameForm);
            GameForm = (Game) gameForm;
            organisms = new List<Organism>();
            logs = new LinkedList<string>();
            randomGenerator = new Random();
            worldSize = size;

            GameManager.SetSize(size);

            GameManager.SetSize(size);
            GameForm.KeyDown += HandleEnterKeyDown;
        }

        public abstract void Display();
        private void HandleEnterKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                enterKeyPressed?.Invoke();
            }
        }
        public int GetHeight() => worldSize.Item1;
        public int GetWidth() => worldSize.Item2;
        public void AddEnterAction(Action action) => enterKeyPressed = action;
        public void ShowGameWindow() => GameForm.Show();
        public void MakeTurn() {}
    }
}
