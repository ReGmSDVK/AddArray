namespace AddArray
{
    class Program
    {
        //Запуск программы начинается всегда с метода main
        static void Main(string[] args)
        {
            int[] array1 = { 1, 1, 1, 1 }; //первый массив
            int[] array2 = { 2, 7, 2, 8 }; //второй массив

            int[] sumArray = AddArrays(array1, array2); //вызов метода сложения двух массивов

            Console.WriteLine("Результат сложения массивов: ");
            foreach (int num in sumArray) //вывод каждого элемента массива на консоль через цикл foreach
            {
                Console.Write(num + " ");
            }
        }
        /// <summary>
        /// Метод для сложения 2 массивов
        /// </summary>
        /// <param name="array1">Принимает в качестве аргумента 1 массив</param>
        /// <param name="array2">Принимает в качестве аргумента 2 массив</param>
        /// <returns>Возвращает результат сложения</returns>
        public static int[] AddArrays(int[] array1, int[] array2) 
        {
            if (array1.Length != array2.Length) //сравнивает длину 2 массивов
            {
                throw new ArgumentException("Длины массивов должны быть одинаковыми."); //выбрасывает ошибку в случае разности длины массивов
            }

            int[] result = new int[array1.Length]; //для сложения 2 массивов необходимо создать новый массив того же размера

            for (int i = 0; i < array1.Length; i++) //обычный цикл который перебирает элементы массива по его длине
            {
                result[i] = array1[i] + array2[i]; //складывает 2 массива и сохраняет результат сложения в 3 (новый) массив
            }

            return result; //возвращает результат
        }
    }
}