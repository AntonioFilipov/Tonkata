
package testingarea;
public class TestingArea {
    public static void main(String[] args) {
        SequentialList list = new SequentialList();
        SequentialList  copiedList = list.copy();
        list.add(6);
        list.add(7);
        list.add(8);
        list.add(9);
        System.out.println(list.get(0));
        System.out.println(list.get(1));
        System.out.println(list.get(2));
        System.out.println(list.get(3));
        copiedList.add(10);

        System.out.println("***********");
        System.out.println(list.copy().get(0));
        System.out.println(list.copy().get(1));
        System.out.println(list.copy().get(2));
        System.out.println(list.copy().get(3));
        System.out.println(list.copy().get(4));

 
        
        //System.out.println(list.get(2));
//        System.out.println(list.get(3));
//        System.out.println(list.size());
//        System.out.println(list.indexOf(6));

        
    }
    
}
