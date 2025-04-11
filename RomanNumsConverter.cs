var symbols = new Dictionary<char,int>(){
    {'I', 1},
    {'V', 5},
    {'X', 10},
    {'L', 50},
    {'C', 100},
    {'D', 500},
    {'M', 1000}
};



while(true){
    System.Console.WriteLine();
    bool err = false;
    System.Console.Write("Введите римское число: ");
    string input = Console.ReadLine();

    int[] ints = new int[input.Length];
    for(int i = 0; i < input.Length; i++){
        if(!symbols.TryGetValue(input[i], out ints[i])){
            System.Console.WriteLine($"Ошибка! Неверный ввод: {input[i]}");
            err = true;
            break;
        }
    }
    if(err){continue;}

    int res = ints[ints.Length - 1];
    int buff = 0;
    int j = 0;
    for( int i = ints.Length-1; i > 0 ; i--){
        if(ints[i-1] >= ints[i]){
            res += ints[i-1];
        }
        else{
            j = i-1;
            buff = 0;
            while(ints[j]<=ints[i]){
                buff += ints[j];
                j-=1;
                if(j<0){break;}
            }
            i=j+2;
            res-= buff;
        }
    }

    System.Console.WriteLine($"Результат в арабских цифрах: {res}");
}