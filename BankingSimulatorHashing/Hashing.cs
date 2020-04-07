using System;

namespace BankingSimulatorHashing
{
    class Hashing
    {
        // declared array and variables
        int size;
        int[] element;
        int hashKey;
        int nextIndexHashKey;
        int front;

        //constructor and variables are initilized in it
        public Hashing(int capacity)
        {
            size = capacity;
            element = new int[size];
            hashKey = 0;
            nextIndexHashKey = 0;
            front = 0;
        }

        /// <insert>
        /// creating hash key and inserting into
        /// key position.
        /// if that position is not vacant then incrementing position
        /// and inserting value.
        /// </insert>
        public void insert(int value)
        {
            hashKey = value % size;
            if (element[hashKey] == 0)
            {
                element[hashKey] = value;
                displayList(hashKey);
            }
            else
            {
                nextIndexHashKey = hashKey + 1;
                while (element[nextIndexHashKey] != 0)
                {
                    nextIndexHashKey += 1;
                }
                if (element[nextIndexHashKey] == 0)
                {
                    element[nextIndexHashKey] = value;
                    displayList(nextIndexHashKey);
                }
            }
        }

        //remove method
        public void remove()
        {
            front += 1;
        }

        // displaying Current Balance
        public void displayList(int key)
        {            
            Console.WriteLine(element[key]);            
        }
    }
}
