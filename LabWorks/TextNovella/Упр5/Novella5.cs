import java.util.Scanner;

public class DepositWithBonus {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        System.out.print("Введите начальную сумму вклада: ");
        double initialAmount = scanner.nextDouble();

        System.out.print("Введите годовую процентную ставку: ");
        double annualRate = scanner.nextDouble();

        System.out.print("Введите срок вклада в годах: ");
        int years = scanner.nextInt();

        double finalAmount = initialAmount;

        for (int i = 0; i < years; i++) {
            finalAmount += finalAmount * (annualRate / 100);
        }

        finalAmount += 15;

        System.out.printf("Итоговая сумма с учетом процентов и бонуса: %.2f", finalAmount);
    }
}