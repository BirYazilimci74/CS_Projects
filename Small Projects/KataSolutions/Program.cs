using System.Runtime.InteropServices;
List<int[]> peopleList = new List<int[]>(){new []{10,0},new []{3,5}, new []{5,8}};

int stopNumber = peopleList.Count;
int peopleNumber = 0;

for(int i = 0; i < stopNumber; i++)
{
    peopleNumber += peopleList[i][0] - peopleList[i][1];
}
return peopleNumber;
