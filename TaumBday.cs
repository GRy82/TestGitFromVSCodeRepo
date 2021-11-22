using System.Collections.Generic;

public class TaumBday : ICodingChallenge
{
    public TaumBday()
    {
    }

    public string RunChallenge(List<int> parameters){
        long minimalCost = taumBday(
            parameters[0],
            parameters[1],
            parameters[2],
            parameters[3],
            parameters[4]
            );
        
        string answer = minimalCost.ToString();  
        return answer;                  
    }

    /*
     * Complete the 'taumBday' function below.
     *
     * The function is expected to return a LONG_INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER b
     *  2. INTEGER w
     *  3. INTEGER bc
     *  4. INTEGER wc
     *  5. INTEGER z
     */

    
    public static long taumBday(int b, int w, int bc, int wc, int z)
    {
        long cost = b * bc + w * wc;
        
        if(bc + z < wc)
            cost = bc * (b + w) + z * w;
        else if(wc + z < bc)
            cost = wc * (w + b) + z * b;        

        return cost;
    }

}