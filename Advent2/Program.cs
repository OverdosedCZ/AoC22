var inputFile = File.ReadAllLines("./input.txt");
var input = new List<string>(inputFile);

// A,X - rock, B,Y - paper, C,Z - scissors



void Part1(){


    var InputScore = new Dictionary<string, int>(){
        {"X", 1},
        {"Y", 2},
        {"Z", 3},
    };

    
    int score = 0;

    foreach(var line in input){
        
        var lineChoices = line.Split(" ");
        var enemyChoice = lineChoices[0];
        var myChoice = lineChoices[1];

        
        if (enemyChoice == "A" && myChoice == "Y" || enemyChoice == "B" && myChoice == "Z" || enemyChoice == "C" && myChoice == "X"){
            score += 6 + InputScore[myChoice];
        }
        else if (enemyChoice == "A" && myChoice == "Z" || enemyChoice == "B" && myChoice == "X" || enemyChoice == "C" && myChoice == "Y"){
            score += InputScore[myChoice];
        }
        else {
            score += 3 + InputScore[myChoice];
        }
    }

    
    Console.WriteLine(score.ToString());

}

void Part2(){

//A - rock, B - paper, C - scissors
//X - lost, Y - draw, Z - win

    var winScore = new Dictionary<string, int>(){
        {"X", 0},
        {"Y", 3},
        {"Z", 6},
    };

    var optionScore = new Dictionary<string, Dictionary<string, int>>(){
        {"A", new Dictionary<string, int>(){{"X", 3}, {"Y", 1}, {"Z", 2}}},
        {"B", new Dictionary<string, int>(){{"X", 1}, {"Y", 2}, {"Z", 3}}},
        {"C", new Dictionary<string, int>(){{"X", 2}, {"Y", 3}, {"Z", 1}}}
    };

    int score = 0;

    foreach(var line in input){
        var lineChoices = line.Split(" ");
        var enemyChoice = lineChoices[0];
        var myChoice = lineChoices[1];

        score += optionScore[enemyChoice][myChoice] + winScore[myChoice];
    }

    Console.WriteLine(score.ToString());
}

Part2();