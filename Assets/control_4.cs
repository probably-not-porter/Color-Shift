// -----
//
// Porter Libby
// Color Shift 2019
//
// -----

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class control_4 : MonoBehaviour
{
    public GameObject[] squares;
    public GameObject gameControl; // top level

    public GameObject spawner; // spawn point hints

    private Color color1 = Color.red;    // default val starting color
    private Color color2 = Color.blue;   // default val majority color
    private Color color3 = Color.green;  // default val target color

    public Color[] colors; // color array 1
    public Color[] colors2; // color array 2

    public float targetTime = 10.0f; // starting time per round
    public float maxTime = 10.0f;
    public float minTime = 3.0f; // fastest possible round time
    public float roundTime = 5.0f;
    public float roundScale = 0.01f; //rate at which speed goes up

    public bool running = false; // is game timer running

    public int target_square = 0;
    public int winstreak = 0;

    // Start is called before the first frame update
    void Start()
    {
        targetTime = maxTime;
        int color1_num = Random.Range(0, colors.Length);
        int color2_num = Random.Range(0, colors2.Length);
        int color3_num = Random.Range(0, colors2.Length);

        color1 = colors[color1_num];    // starting color
        color2 = colors2[color2_num];   // majority color
        color3 = colors2[color3_num];  // odd color

        target_square = Random.Range(0, squares.Length); // choose random starting answer
        squares[0].GetComponent<Button>().onClick.AddListener(delegate { ButtonHandle(0); }); //do this badly because the loop isnt working ???
        squares[1].GetComponent<Button>().onClick.AddListener(delegate { ButtonHandle(1); });
        squares[2].GetComponent<Button>().onClick.AddListener(delegate { ButtonHandle(2); });
        squares[3].GetComponent<Button>().onClick.AddListener(delegate { ButtonHandle(3); });
        squares[4].GetComponent<Button>().onClick.AddListener(delegate { ButtonHandle(4); });
        squares[5].GetComponent<Button>().onClick.AddListener(delegate { ButtonHandle(5); });
        squares[6].GetComponent<Button>().onClick.AddListener(delegate { ButtonHandle(6); });
        squares[7].GetComponent<Button>().onClick.AddListener(delegate { ButtonHandle(7); });
        squares[8].GetComponent<Button>().onClick.AddListener(delegate { ButtonHandle(8); });
        squares[9].GetComponent<Button>().onClick.AddListener(delegate { ButtonHandle(9); }); //do this badly because the loop isnt working ???
        squares[10].GetComponent<Button>().onClick.AddListener(delegate { ButtonHandle(10); });
        squares[11].GetComponent<Button>().onClick.AddListener(delegate { ButtonHandle(11); });
        squares[12].GetComponent<Button>().onClick.AddListener(delegate { ButtonHandle(12); });
        squares[13].GetComponent<Button>().onClick.AddListener(delegate { ButtonHandle(13); });
        squares[14].GetComponent<Button>().onClick.AddListener(delegate { ButtonHandle(14); });
        squares[15].GetComponent<Button>().onClick.AddListener(delegate { ButtonHandle(15); });

        for (int x = 0; x < squares.Length; x++)
        {
            ChangeColor(color1, squares[x]);
        }
    }

    void ButtonHandle(int x) // handle when one of the buttons is pressed win/lose
    {
        if (x == target_square)
        {
            WinGame();
        }
        else
        {
            if (gameControl.GetComponent<screenControl>().activescreen == 4)
            {
                gameControl.GetComponent<screenControl>().lastscreen = 4;
                gameControl.GetComponent<screenControl>().activescreen = 2;
            }
        }
    }

    void timerEnded() // player ran out of time to chose
    {
        if (gameControl.GetComponent<screenControl>().activescreen == 4)
        {
            gameControl.GetComponent<screenControl>().lastscreen = 4;
            gameControl.GetComponent<screenControl>().activescreen = 2;
        }
    }

    void ChangeColor(Color color, GameObject button)
    {
        button.GetComponent<Image>().color = color;
    }

    public void LoseGame()
    {
        Debug.Log("You lost");
        winstreak = 0;
        //play again prompt
        Reload();
        roundTime = maxTime;
    }

    void WinGame()
    {
        Debug.Log("You Win");
        //do other stuff
        winstreak++;
        spawner.GetComponent<produce_numbers>().create1();

        Reload();
    }

    public void Reload() // reload the game screen reset all vars except streak
    {
        int color1_num = Random.Range(0, colors.Length);
        int color2_num = Random.Range(0, colors2.Length);
        int color3_num = Random.Range(0, colors2.Length);

        color1 = colors[color1_num];    // starting color
        color2 = colors2[color2_num];   // majority color
        color3 = colors2[color3_num];  // odd color

        if (roundTime > minTime)
        {
            targetTime = roundTime * 1.0f - roundScale;
        }
        else
        {
            targetTime = minTime;
        }
        roundTime = targetTime;

        target_square = Random.Range(0, squares.Length);
        for (int x = 0; x < squares.Length; x++)
        {
            ChangeColor(color1, squares[x]);
        }
    }

    void Update()
    {
        // UPDATE SQUARE COLORS
        for (int x = 0; x < squares.Length; x++)
        {
            if (x == target_square)
            {
                Color new_color = Color.Lerp(color3, color1, (targetTime * roundTime));
                ChangeColor(new_color, squares[x]);
            }
            else
            {
                Color new_color = Color.Lerp(color2, color1, (targetTime / roundTime));
                ChangeColor(new_color, squares[x]);
            }
        }

        // CHECK TO SEE IF TIMER HAS RUN OUT
        if (running == true)
        {
            targetTime -= Time.deltaTime;
        }
        if (targetTime <= 0.0f)
        {
            running = false;
            targetTime = 5.0f;
            timerEnded();
        }
    }

}
