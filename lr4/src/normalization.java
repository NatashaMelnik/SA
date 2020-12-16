import java.util.List;
import java.util.ArrayList;

public class normalization {
    private static Double[][] normalization(Double[][] F, int m) {
        double aj;
        int row = 0;
        int iter = 1;
        Double[][] normMass = new Double[m - 1][5];
        Double[][] middleMas = new Double[m][5];
        for (int i = 0; i<normMass.length; i++) {
            for (int j = 0; j < 5; j++) {
                normMass[i][j] = 0.;}}
        for (int k = 0; k < m - 1; k++) {
            for (int i = 0; i<F.length; i++) {
                aj = F[i][iter];
                for (int j = 0; j < F[i].length; j++) {
                    middleMas[i][j] = F[i][j] * aj;}}
            System.out.println();
            for (int i = 0; i<middleMas.length; i++) {
                for (int j = 0; j < 5; j++) {
                    System.out.print(middleMas[i][j] + "     ");}
                System.out.println();}
            iter++;
            List<Double> elements = getElements(middleMas);
            for (int j = 0; j < 5; j++) {
                normMass[row][j] = elements.get(j);}
            if (row < m) {
                row++;}}
        System.out.println();
        for (int i = 0; i<normMass.length; i++) {
            for (int j = 0; j < 5; j++) {
                System.out.print(normMass[i][j] + "     ");}
            System.out.println();}
        return normMass;}
}
