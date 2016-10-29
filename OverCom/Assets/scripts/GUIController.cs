using UnityEngine;

public class GUIController : MonoBehaviour
{
    public CellGrid CellGrid;
	
    void Start()
    {
        Debug.Log("Press 'Enter' to end turn");
    }

	void Update ()
    {
        if(Input.GetKeyDown(KeyCode.Return))
        {
            CellGrid.EndTurn();//User ends his turn by pressing "n" on keyboard.
        }
	}
}
