using System.Linq;

List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();    
int indexPosition = int.Parse(Console.ReadLine());
int damage = 1;
string stopWord = "Supernova";

do
{
    List<string> input = Console.ReadLine().Split(' ').ToList();
    string directions = input[0];
    if (directions == stopWord)
    {
        break;
    }
    int steps = int.Parse(input[1]);
    for (int i = 0; i < steps; i++)
    {
        if (directions == "right")
        {
            indexPosition++;
            if (indexPosition>=nums.Count)
            {
                indexPosition = 0;
                damage++;
            }
            nums[indexPosition] -= damage;
        }
        else if (directions == "left")
        {
            indexPosition--;
            if (indexPosition < 0)
            {
                indexPosition = nums.Count-1;
                damage++;   
            }
            nums[indexPosition] -= damage ;
        }
     
    }
} while (true);
for (int i = 0; i < nums.Count; i++)
{
    Console.Write(nums[i]+ " ");
}
