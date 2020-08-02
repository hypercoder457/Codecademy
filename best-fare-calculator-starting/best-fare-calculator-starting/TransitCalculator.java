public class TransitCalculator {

    String[] rideOptions = {"Pay-per-ride", "7 day unlimited rides", "30 day unlimited rides"};
    double[] prices = {2.75, 33.00, 127.00};

    int days;
    int rides;
    
    public TransitCalculator(int numOfDays, int numOfRides) {
        days = numOfDays;
        rides = numOfRides;
    }

    public double unlimited7Price() {
        double numOfWeeks = Math.ceil(days / 7.0);
        double totalCost = numOfWeeks * prices[1];
        return totalCost / rides;
    }

    public double[] getRidePrices() {
        double payPerRidePrice = prices[0];
        double sevenDayPrice = unlimited7Price();
        double thirtyDayPrice = prices[2] / rides;
        double[] fares = { payPerRidePrice, sevenDayPrice, thirtyDayPrice };
        return fares;
    }

    public String getBestFare() {

        double[] ridePrices = getRidePrices();
        int winningIndex = 0;

        for (int i = 0; i < ridePrices.length; i++) {
            
            if (ridePrices[i] < ridePrices[winningIndex]){

                winningIndex = i;

            }

        }

        return "You should get the " + rideOptions[winningIndex] + " option at $" + Math.round(ridePrices[winningIndex] * 100.0) / 100.0 + " per ride.";
    }
    
    public static void main(String[] args) {
        int myRides = 54;
        int myDays = 26;

        TransitCalculator transitCalc = new TransitCalculator(myRides, myDays);
        System.out.println(transitCalc.getBestFare());
    }
}