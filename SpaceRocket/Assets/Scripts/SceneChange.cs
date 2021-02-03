using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    public void button_change_scene(string scene_name)
    {
        SceneManager.LoadScene(scene_name);
    }
}
