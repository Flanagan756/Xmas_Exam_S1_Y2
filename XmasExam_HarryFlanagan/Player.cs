using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/***Author: Harry Flanagan***/
/***Date: 11/12/2019***/

namespace XmasExam_HarryFlanagan
{
    /*Enums*/
    public enum Position
    {
        GoalKeeper,
        Defender,
        Midfielder,
        Forward
    }
    class Player
    {


        /*Properties*/
        public string  FirstName { get; set; }
        public string Surname { get; set; }
        public Position PreferedPosistion { get; set; }
        public  DateTime DateOfBirth { get; set; }
        public int Age { get; set; }

        /*Constructor*/
        public Player(string firstName, string surname, Position preferedPostion, DateTime dateOfBirth)
        {
            FirstName = firstName;
            Surname = surname;
            PreferedPosistion = preferedPostion;
            DateOfBirth = dateOfBirth;
        }
    
    }
    /*Methods*/
    public override

}
