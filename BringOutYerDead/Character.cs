using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BringOutYerDead
{
    class Character
    {
        private string name;
        private int age;
        private bool sex;

        public Character()
        {
            this.name = null;
            this.age = 0;
            this.sex = false;
        }

        public Character(string _name,int _age, bool _sex)
        {
            this.name = _name;
            this.age = _age;
            this.sex = _sex;
        }

        public List<Character> CharactersList = new List<Character>();

        string GetName()
        {
            return name;
        }

        int GetAge()
        {
            return age;
        }

        bool GetSex()
        {
            return sex;
        }

        public void AddCharacter(string _name, int _age, bool _sex)
        {
            CharactersList.Add(new Character(_name,_age,_sex));
        }

        public void ModifyCharacter(string _name, int _age, bool _sex, int index)
        {
            CharactersList[index].name = _name;
            CharactersList[index].age = _age;
            CharactersList[index].sex = _sex;
        }

        public void RemoveCharacter(int index)
        {
            CharactersList.RemoveAt(index);
        }

    }
}
