using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loading
{
    
    public Loading()
    {
        
    }

    public IEnumerator LoadingScene()
    {
        for (float ft = 1f; ft >= 0; ft -= 0.1f)
        {
            Color c = renderer.material.color;
            c.a = ft;
            renderer.material.color = c;
        }
        yield return new WaitForSeconds(.1f);
    }
}
