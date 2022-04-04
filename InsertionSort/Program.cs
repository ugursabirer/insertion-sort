using System;

namespace InsertionSort
{
    class IS
    {
        void sort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n; ++i)
            {
                int key = arr[i];
                int j = i - 1;

                // arr[0..i-1] öğelerini taşıyoruz.
                // key den büyük olanları bir pozisyon ileri, mevcut konumları ile değiştiriyoruz.
                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }
                arr[j + 1] = key;

                // Aşağıda diziyi sıralarken adım adım yazdırıyoruz.
                for (int k = 0; k < n; ++k)
                {
                    Console.Write(arr[k] + " ");
                }
                Console.WriteLine("\n");
            }
        }

        static void printArray(int[] arr)
        {
            Console.Write("Sıralanmış Dizi: ");
            int n = arr.Length;
            for (int i = 0; i < n; ++i)
            {
                Console.Write(arr[i] + " ");
            }
        }

        static void Main(string[] args)
        {
            int[] arr = { 7, 3, 5, 8, 2, 9, 4, 15, 6 };
            IS inSo = new IS();
            inSo.sort(arr);
            printArray(arr);
        }
    }
}

/*
[22, 27, 16, 2, 18, 6] -> Insertion Sort

    1. Yukarı verilen dizinin sort türüne göre aşamalarını yazınız.
    2. Big-O gösterimini yazınız.
    3. Time Complexity: Average case: Aradığımız sayının ortada olması,Worst case: Aradığımız sayının sonda olması, Best case: Aradığımız sayının dizinin en başında olması.
    4. Dizi sıralandıktan sonra 18 sayısı hangi case kapsamına girer? Yazınız.

1. Adım: 16 22 27 2 18 6 (Diziyi gezerek karşılaştığı ilk en küçük değer olan 16'yı en başa aldı.)

2. Adım: 2 16 22 27 18 6 (Tekrar gezerek 16'dan küçük 2'yi buldu ve en başa aldı.)

3. Adım: 2 16 18 22 27 6 (Tekrar gezerek 2'den değil 16'dan da değil 22'den küçük 18 değerini bularak 16'dan sonraki kısma aldı.)

4. Adım: 2 6 16 18 22 27 (Tekrar gezerek 2'den değil ancak 16'dan küçük 6 değerini bularak 2'den sonraki kısma aldı.)

    2. Big-O notasyonuna göre zaman karmaşıklığı O(n^2) çıkmaktadır.
    3. Time Complexity, Average case: O(n), Worst case: O(n^2), Best case: O(1)
    4. Dizi sıralandıktan sonra 18 sayısı, sıralı bir dizi olduğunu varsayarsak O(1), ancak genel olarak O(n) ile Average case kapsamına girer.
*/

/*
[7, 3, 5, 8, 2, 9, 4, 15, 6] dizisinin Insertion Sort'a göre ilk 4 adımını yazınız.

Sıralama şu şekilde ilerlemektedir:

1. Adım: 7 3 5 8 2 9 4 15 6

2. Adım: 3 7 5 8 2 9 4 15 6

3. Adım: 3 5 7 8 2 9 4 15 6

4. Adım: 2 3 5 7 8 9 4 15 6 (İlk dört adım burada noktalanıyor.)

5. Adım: 2 3 4 5 7 8 9 15 6

6. Adım: 2 3 4 5 6 7 8 9 15 (Son olarak bu adımda sıralama bitiyor.)
*/