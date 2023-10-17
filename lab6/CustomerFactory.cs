public class CustomerFactory{
    public static Customer CreateCustomer(string type){
        if (type == "Mountain"){
            return new MountainCustomer();
        }
        else if (type == "Delinquent"){
            return new DelinquentCustomer();
        }
        else if (type == "Regular"){
            return new RegularCustomer();
        }
        return null;
    }
}
