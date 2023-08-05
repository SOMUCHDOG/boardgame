using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(Shiproll());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /// <summary>
    /// Returns a dice roll
    /// </summary>
    /// <returns></returns>
    private int RollDice()
    {
        return Random.Range(1, 7) + Random.Range(1, 7);
    }

    private int Shiproll()
    {
        List<string> ballz = new List<string> { "blue", "yellow", "yellow", "black", "red"};
        int n = 3;

        List<string> roll = new List<string>();
        int sum = 0;

        for (int i = 0; i < n; i++)
        {
            int p = Random.Range(0, ballz.Count - 1);
            roll.Add(ballz[p]);
            sum += GetBallValue(ballz[p]);
            ballz.Remove(ballz[p]);
        }

        return sum;

    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="s"></param>
    /// <returns></returns>
    private int GetBallValue(string s)
    {
        switch(s)
        {
            case "blue":
                return 2;
               
            case "yellow":
                return 1;

            case "red":
                return 3;

            case "black":
                return 0;

            default:
                return 0;
        }
    }
}
