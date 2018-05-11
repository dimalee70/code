using System;
namespace lesson13{
    class MyPoint{
        private int x;
        private int y;
        private int z;
        
        public int myX{
            get{
                return x;
            }
            set{
                x = value;
            }
        }
        public int myY{
            get{
                return y;
            }
            set{
                y = value;
            }
        }
        public int myZ{
            get{
                return z;
            }
            set{
                z = value;
            }
        }
        public MyPoint(int x,int y,int z){
            this.x = x;
            this.y = y;
            this.z = z;
        }
        public static MyPoint operator +(MyPoint mp1,MyPoint mp2){
            MyPoint mp3 = new MyPoint(mp1.myX + mp2.myX,mp1.myY+mp2.myY,mp1.myZ+mp2.myZ);
            return mp3;
        }
        public static MyPoint operator ++(MyPoint myPoint){
            myPoint.myX+=2;
            myPoint.myZ+=2;
            myPoint.myY+=2;
            return myPoint;
        }
        public static bool operator true(MyPoint myPoint){
            if(myPoint.myX > 0 && myPoint.myY > 0 && myPoint.myZ > 0){
                return true;
            }else
            return false;
        }
        public static bool operator false(MyPoint myPoint){
            if(myPoint.myX > 0 && myPoint.myY > 0 && myPoint.myZ > 0){
                return true;
            }else
            return false;
        }
        public static bool operator >(MyPoint myPoint,MyPoint mp2){
            if(myPoint.myX > mp2.myX && myPoint.myY > mp2.myY && myPoint.myZ > mp2.myZ){
                return true;
            }else
                return false;
        }
        public static bool operator <(MyPoint myPoint,MyPoint mp2){
            if(myPoint.myX < mp2.myX && myPoint.myY < mp2.myY && myPoint.myZ < mp2.myZ){
                return true;
            }else
                return false;
        }
        public static bool operator |(MyPoint myPoint,MyPoint myPoint2){
            if( (myPoint.myZ | myPoint2.myZ) < 0 || (myPoint.myX | myPoint2.myX) < 0 || (myPoint.myZ | myPoint2.myZ) < 0){
                return true;
            }else{
                return false;
            }
        }
        public static bool operator &(MyPoint myPoint,MyPoint myPoint2){
            if( (myPoint.myZ & myPoint2.myZ) < 0 && (myPoint.myX & myPoint2.myX) < 0 && (myPoint.myZ & myPoint2.myZ) < 0){
                return true;
            }else{
                return false;
            }
        }
 //       public  static explicit operator string(MyPoint myPoint){
  //          return "Coordinate " + myPoint.myX + " " + myPoint.myY + " " + myPoint.myZ;
   //     }
        public  static implicit operator string(MyPoint myPoint){
            return "Coordinate " + myPoint.myX + " " + myPoint.myY + " " + myPoint.myZ;
        }
        public static explicit operator int[](MyPoint myPoint){
            int [] arr = new int [3];
            arr[0] = myPoint.myX;
            arr[1] = myPoint.myY;
            arr[2] = myPoint.myZ;
            return arr; 
        }
    }
}