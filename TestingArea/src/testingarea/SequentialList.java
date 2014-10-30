package testingarea;
public class SequentialList {
    private static final int INITIAL_SIZE = 2;
    private int[] array;
    private int elementCount;
    
    public SequentialList(){
        this.array = new int[INITIAL_SIZE];
        this.elementCount = 0;
    }
    
    public void add(int element){
        this.grow();
        this.array[this.elementCount] = element;
        this.elementCount++;
    }
    
    public void insert(int element, int index){
        if (index >= this.elementCount){
            this.add(element);
            return;
        }
        this.grow();
        if(this.elementCount == this.array.length){
            this.grow();
        }
        
        for (int i = this.elementCount - 1; i >= index; i--){
            this.array[i+1] = this.array[i];
            this.array[i] = element;
        }
        this.array[index] = element;
        this.elementCount++;
    }
    
    public int size(){
        return this.elementCount;
    }
    
    public int indexOf(int element){
        int index = -1;
        for (int i=0; i<this.array.length; i++){
            if (this.array[i] == element){
                index = i;
            }
        }
        return index;
    }
    public int get(int index){
        return this.array[index];
    }
    
    public void grow(){
        if(this.elementCount == this.array.length){
            int[] newArray= new int [INITIAL_SIZE *2];
            for(int i=0; i < this.array.length; i++){
                newArray[i]=this.array[i];
            }
            this.array = newArray;
        }
    }
    
    public void removeAt(int index){
        int[] removeArray = new int[this.elementCount - 1];

        for (int i=0; i< this.elementCount - 1; i++){
            if(i >= index){
                removeArray[i] = this.array[i+1];
            }
            else{
            removeArray[i] = this.array[i];
            }
        }
        this.array = removeArray;
        this.elementCount--;
    }
    
    public boolean removeElement(int element){
        int[] removeArray = new int[this.elementCount - 1];
        for (int i=0; i< this.elementCount - 1; i++){
            if (this.array[i]==element){
                for (int j = i; j<this.elementCount - 1; j++){
                    removeArray[j] = this.array[j+1];
                }
                return true;
            }
            else
            removeArray[i] =this.array[i];
        }
        this.array = removeArray;
        this.elementCount--;
        return false;
    }
    
    SequentialList copy(){
        
        SequentialList copy_list = new SequentialList();
        //int[] copy_array = new int[this.array.length];
        for(int i=0; i < this.array.length; i++){
            copy_list.add(this.array[i]);
        }
       
        return copy_list;
        
        
    }
}
        
