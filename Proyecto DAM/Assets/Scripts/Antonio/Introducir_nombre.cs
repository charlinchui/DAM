<<<<<<< HEAD
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Introducir_nombre : MonoBehaviour
{
    public void OnValueChangedPlayerName()
    {
        GameObject.FindGameObjectWithTag("Game").GetComponent<GameController>().playerName = GetComponent<InputField>().text;
    }
}
=======
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Introducir_nombre : MonoBehaviour
{
    public void OnValueChangedPlayerName()
    {
        GameObject.FindGameObjectWithTag("Game").GetComponent<GameController>().playerName = GetComponent<InputField>().text;
    }
}
>>>>>>> parent of 3b68fc4 (Revert "Merge branch 'main' of https://github.com/charlinchui/DAM")
