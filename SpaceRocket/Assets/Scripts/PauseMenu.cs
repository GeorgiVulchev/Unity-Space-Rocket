using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public void ClickContinue()
    {
        gameObject.SetActive(false);
        Time.timeScale = 1;
    }
}
