var inputFile = File.ReadAllLines("./input.txt");
var input = new List<string>(inputFile);

int[] elfCalorie = new int [3];

int currentCalorie = 0;

foreach (var line in input){
    if (line == ""){
        for (int i = 0; i < 3; i++){
            if (currentCalorie > elfCalorie[i]){
                if (i != 0){
                    elfCalorie[i-1] = elfCalorie[i];
                }
                elfCalorie[i] = currentCalorie;
            }
        }
        currentCalorie = 0;
    }
    else {
        currentCalorie += Int32.Parse(line);
    }
}
    int totalCalorie = 0;

    foreach(int num in elfCalorie){
        totalCalorie += num;
    }

   Console.WriteLine(totalCalorie.ToString());