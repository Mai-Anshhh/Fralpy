using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class logicscript : MonoBehaviour
{
    public int playerscore;
    public Text scoretext;
    public GameObject gameoverpanel;

    [ContextMenu("Add Score")]
    public void addscore(int scoretoadd)
    {
        playerscore += scoretoadd;
        scoretext.text = playerscore.ToString();
    }

    public void restartgame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameover()
    {
        gameoverpanel.SetActive(true);
    }

}
