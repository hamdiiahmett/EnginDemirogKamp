using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsIntro
{
    class MyList<T> 
    {
        T[] items; 

        //constructor
        public MyList() //classi newlersen burasi otomatik calisir ve items = new T[0];  eklenir
        {
            items = new T[0]; 
        }
        public void Add(T item)
        {
            T[] tempArray = items; //gecici dizi
            items = new T[items.Length + 1];
            for (int i = 0; i < tempArray.Length; i++)//simdi gecici diziye attiklarimizi geri alcaz
            {
                items[i] = tempArray[i];
            }
            items[items.Length - 1] = item; //itemsin son elemani esittir yukardan add ile gelen item
        }
    }
}
