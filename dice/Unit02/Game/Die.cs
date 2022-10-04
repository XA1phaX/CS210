using System;


namespace Unit02.Game
{
    // TODO: Implement the Die class as follows...
    // 1) Add the class declaration. Use the following class comment.
    // 2) Add the following private fields:


        /// <summary>
        /// A small cube with a different number of spots on each of its six sides.
        /// The responsibility of Die is to keep track of its currently rolled value and the points its
        /// worth.
        /// </summary> 
    public class Die{
        public int _value;
        public int _points;

        /// <summary>
        /// Gets the value of the die.
        /// </summary>


     // 2) Create the class constructor. Use the following method comment.
        public Die(){
        /// <summary>
        /// Constructs a new instance of Die.
        /// </summary>
        }

     // 3) Create the Roll() method. Use the following method comment.        
        public void Roll(){
            Random random = new Random();
            _value = random.Next(1,7);
            if(_value ==1){
                _points = 100;
            }
            else if(_value == 5){
                _points = 50;
            }
            else{
                _points = 0;
            }

        /// <summary>
        /// Generates a new random value and calculates the points for the die. Fives are 
        /// worth 50 points, ones are worth 100 points, everything else is worth 0 points.
        /// </summary>
        }
    }


}

    
   
        
