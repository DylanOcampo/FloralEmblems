using UnityEngine;

public class Drag : MonoBehaviour {
  
  public bool isDragging;
  public Vector2 xvalues;
  public Vector2 yvalues;

  // Update is called once per frame
  void Update() {
    if(isDragging){
        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition)- transform.position;
        
        transform.Translate(mousePosition);

        Vector2 truemousePosition;
        truemousePosition.x = Mathf.Clamp(transform.position.x, xvalues.x ,xvalues.y);
        truemousePosition.y = Mathf.Clamp(transform.position.y, yvalues.x ,yvalues.y);
        transform.position = truemousePosition;
    }
  }

  private void OnMouseDown() {
    isDragging = true;
  }

  private void OnMouseUp() {
    isDragging = false;
  }


}