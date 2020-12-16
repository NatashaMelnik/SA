import java.util.ArrayList;
import java.util.List;

public class list {
    private static List<Double>getElements(Double[][] mass) {
        List<Double> elements = new ArrayList<>();
        for (int i = 0; i<mass.length; i++) {
            double flag = 0;
            for (int j = 0; j < 5; j++) {
                flag += mass[j][i];}
            elements.add(flag);}
        return elements;}
}
