/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package testingarea;

/**
 *
 * @author Tonkata
 */
public class NewClass {
    private int[] array;
    private int ARRAY_LENGTH = 2;
    private int counter = 0;
    
    public NewClass(){
      this.array = new int[ARRAY_LENGTH];
    
    }
    
    public void add(int element){
        this.array[counter] = element;
        counter++;
    }
    
    public int get(int index){
        return this.array[index];
    }
}
