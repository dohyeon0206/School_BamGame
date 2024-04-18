using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CourotinTest : MonoBehaviour
{
    public int num;
    public int sum;

    // Start is called before the first frame update
    void Start()
    {
        num = 0;
        sum = 0;
        StartCoroutine(Sum());
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.DownArrow)) 
            StopCoroutine(Sum());
    }

    IEnumerator Sum()
    {
        
        while (num <= 100 )
        {
            sum += num;

            if (num < 11)
            {
                Debug.Log(sum + ", " + num);
                yield return new WaitForSeconds(1);
            }
            else if (num < 51)
            {
                Debug.Log(sum + ", " + num);
                yield return new WaitForEndOfFrame();
            }
            else if(num < 71)
            {
                Debug.Log(sum + ", " + num);
                yield return new WaitUntil(() => Input.GetKey(KeyCode.UpArrow));
            }
            else if(num < 101)
            {
                Debug.Log(sum + ", " + num);
                yield return null;
            }

            num++;
        }
    }
}
