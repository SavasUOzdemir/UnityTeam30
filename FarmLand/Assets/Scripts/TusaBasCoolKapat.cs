using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TusaBasCoolKapat: MonoBehaviour
  {
    public GameObject basilmisobject;
    public GameObject basilmamisobject;
    public GameObject settingsmenu;
    private void Awake()
    {
        basilmisobject.SetActive(false);
        basilmamisobject.SetActive(true);
    }
    public void PlayGame()
    {
        if (basilmisobject.activeSelf == false)
        {
            StartCoroutine(ClickDelay());
            settingsmenu.transform.LeanScale(new Vector3(0, 0, 0), 0.2f);

        }
    }
    IEnumerator ClickDelay()
    {
        basilmamisobject.SetActive(false);
        basilmisobject.SetActive(true);
        yield return new WaitForSeconds(0.2f);
        basilmisobject.SetActive(false);
        basilmamisobject.SetActive(true);
    }
}