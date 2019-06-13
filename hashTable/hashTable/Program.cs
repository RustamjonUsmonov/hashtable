using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hashTable
{
    class ThisTable
    {
        static Hashtable userInfoHash;
    }
    class Program
    {
        static void Main(string[] args)
        {
           var userInfoHash = new Hashtable();

            //Добавление
            for (int i = 0; i < 10; i++)
            {
                userInfoHash.Add(i,"user"+i);
            }

            //удаление
            if (userInfoHash.ContainsKey(0))
            {
                userInfoHash.Remove(0);
            }

            //замена
            if (userInfoHash.ContainsKey(1))
            {
                userInfoHash[1]="replaced";
            }

            //вывод
            foreach (DictionaryEntry entry in userInfoHash)
            {
                Console.WriteLine("Key:"+entry.Key+"/Value:"+entry.Value);
            }
            Console.ReadKey();
        }
    }
}

//******************************************очередь с приоритетом
//using System;
//using System.Text;

//namespace PriorityQueue
//{
//    class Elem
//    {
//        public int Task { get; set; }
//        public int Priority { get; set; }

//        public override string ToString()
//        {
//            return $"{Priority}:{Task}";
//        }
//    }

//    class PriorityQueue
//    {
//        public int Capacity { get; private set; }
//        private Elem[] data;
//        private Elem[] oldData;

//        public PriorityQueue(Elem[] inputData)
//        {
//            Capacity = inputData.Length;
//            oldData = new Elem[Capacity + 1];
//            data = new Elem[2 * Capacity];
//            for (int i = 0; i < Capacity; i++)
//            {
//                oldData[i] = inputData[i];
//                data[Capacity + i] = inputData[i];
//            }
//            FillQueue();
//        }

//        private void FillQueue()
//        {
//            for (int k = Capacity - 1; k > 0; k--)
//            {
//                if (data[2 * k].Priority > data[2 * k + 1].Priority)
//                    data[k] = data[2 * k];
//                else
//                    data[k] = data[2 * k + 1];
//            }
//        }

//        public PriorityQueue AddElem(Elem elem)
//        {
//            var newData = oldData;
//            newData[oldData.Length - 1] = elem;
//            return new PriorityQueue(newData);
//        }

//        public PriorityQueue GetElem(int n)
//        {
//            oldData[n] = null;
//            var newData = new Elem[oldData.Length - 2];
//            int k = 0;
//            for (var i = 0; i < oldData.Length - 1; i++)
//            {
//                if (oldData[i] != null)
//                {
//                    newData[k] = oldData[i];
//                    k++;
//                }
//            }
//            return new PriorityQueue(newData);
//        }



//        public override string ToString()
//        {
//            StringBuilder sb = new StringBuilder();
//            for (int k = 1; k < 2 * Capacity; k++)
//            {
//                sb.AppendLine($"{k} -- {data[k]}");
//            }
//            return sb.ToString();
//        }

//    }

//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Elem[] data = { new Elem { Priority = 1, Task = 1 },
//                            new Elem { Priority = 2, Task = 2 },
//                            new Elem { Priority = -1, Task = -1 },
//                            new Elem { Priority = 4, Task = 4 },
//                            new Elem { Priority = 5, Task = 5 },
//                            new Elem { Priority = 5, Task = 6 },
//                            new Elem { Priority = 3, Task = 7 },
//                            new Elem { Priority = 4, Task = 8 }};
//            PriorityQueue queue = new PriorityQueue(data);
//            Console.WriteLine(queue);
//            Console.WriteLine(queue.AddElem(new Elem { Priority = 5, Task = 2 }));
//            Console.WriteLine(queue.GetElem(4));

//            Console.ReadKey();
//        }
//    }
//}
