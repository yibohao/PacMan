using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartScene_Flash : MonoBehaviour
{
    [SerializeField] Text title;
    [SerializeField] Image[] borders;

    Color textColor = new Color(0,39,233);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        title.color = clerp(textColor, Color.white,2f);
    }

    Color clerp(Color color1, Color color2, float speed) => Color.Lerp(color1, color2, Mathf.Sin(Time.time) * speed);
}
