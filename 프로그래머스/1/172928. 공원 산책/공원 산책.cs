public class Solution {
    public int[] solution(string[] park, string[] routes) {
        int w = park[0].Length;
        int h = park.Length;
        int x = 0;
        int y = 0;
        
        for(int i = 0; i < h; i++)
        {
            for(int j = 0; j < w; j++)
            {
                if(park[i][j] == 'S')
                {
                    x = j;
                    y = i;
                    break;
                }
            }
        }
        
        for(int i = 0; i < routes.Length; i++)
        {
            int tempX = x;
            int tempY = y;
            
            if(routes[i][0] == 'N')
            {
                tempY -= routes[i][2] - '0'; 
            }
            else if(routes[i][0] == 'S')
            {
                tempY += routes[i][2] - '0'; 
            }
            else if(routes[i][0] == 'W')
            {
                tempX -= routes[i][2] - '0'; 
            }
            else if(routes[i][0] == 'E')
            {
                tempX += routes[i][2] - '0'; 
            }
            
            if(tempX < w && tempX > -1 && tempY < h && tempY > -1)
            {
                bool check = true;
                
                if(tempX > x)
                {
                    for(int j = x; j <= tempX; j++)
                    {
                        if(park[y][j] == 'X')
                        {
                            check = false;
                            break;
                        }
                    }
                }
                else if(tempX < x)
                {
                    for(int j = tempX; j <= x; j++)
                    {
                        if(park[y][j] == 'X')
                        {
                            check = false;
                            break;
                        }
                    }
                }
                else if(tempY > y)
                {
                    for(int j = y; j <= tempY; j++)
                    {
                        if(park[j][x] == 'X')
                        {
                            check = false;
                            break;
                        }
                    }
                }
                else if(tempY < y)
                {
                    for(int j = tempY; j <= y; j++)
                    {
                        if(park[j][x] == 'X')
                        {
                            check = false;
                            break;
                        }
                    }
                }
                
                if(check == true)
                {
                    x = tempX;
                    y = tempY;
                }
            }
            
        }
        
        int[] answer = new int[2]{y, x};
        return answer;
    }
}