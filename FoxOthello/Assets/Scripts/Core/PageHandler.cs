using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PageHandler
{
    // singleton
    private static PageHandler instance;
    public static PageHandler Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new PageHandler();
            }
            return instance;
        }
    }
}
