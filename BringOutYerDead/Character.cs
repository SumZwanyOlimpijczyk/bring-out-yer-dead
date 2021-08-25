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
        private int birthdate;
        private bool sex;

        public Character()
        {
            this.name = null;
            this.birthdate = 0;
            this.sex = false;
        }

        public Character(string _name,int _birthdate, bool _sex)
        {
            this.name = _name;
            this.birthdate = _birthdate;
            this.sex = _sex;
        }

        public List<Character> CharactersList = new List<Character>();

        string GetName()
        {
            return name;
        }

        int GetBirthdate()
        {
            return birthdate;
        }

        bool GetSex()
        {
            return sex;
        }

        public void AddCharacter(string _name, int _birthdate, bool _sex)
        {
            CharactersList.Add(new Character(_name,_birthdate,_sex));
        }

        public void ModifyCharacter(string _name, int _birthdate, bool _sex, int index)
        {
            CharactersList[index].name = _name;
            CharactersList[index].birthdate = _birthdate;
            CharactersList[index].sex = _sex;
        }

        public void RemoveCharacter(int index)
        {
            CharactersList.RemoveAt(index);
        }

    }
}
