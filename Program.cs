void Write(string message){
    Console.WriteLine(message);
}
Write("Введите размер массива");
int length=int.Parse(Console.ReadLine()!);
Write("Введите массив");
string[] array = new string[length];
InputArr(array, length);
PrintNewArr(array, length);
void InputArr(string[] array, int length){
    for(int i = 0; i < length; i++){
        array[i]=Console.ReadLine()!;
    }
}
void PrintNewArr(string[] array, int length){
    for(int i = 0; i < length; i++){
        if(array[i].Length<=3){
            Console.WriteLine(array[i]);
            Console.WriteLine();
        }
    }
}
