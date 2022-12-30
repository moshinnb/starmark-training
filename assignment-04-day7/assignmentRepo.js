class vehicle {
    static id = 0;
    constructor(vNo, type) {

        this.id = ++vehicle.id;
        this.vNo = vNo;
        this.type = type;
        this.date = new Date();
    }
}

class ToolManager {
    #vehicle = []
    getVehicle = () => this.#vehicle;
    addCar = (vNo) => this.#vehicle.push(new vehicle(vNo, "CAR"));//{}
    addTruck = (vNo) => this.#vehicle.push(new vehicle(vNo, "TRUCK"));
    addBus = (vNo) => this.#vehicle.push(new vehicle(vNo, "BUS"));

    totalCar = () => this.#vehicle.filter(e => e.type == "CAR").length;
    totalTruck = () => this.#vehicle.filter(e => e.type == "TRUCK").length;
    totalBus = () => this.#vehicle.filter(e => e.type == "BUS").length;
    totalCarC = () => this.totalCar() * 50;
    totalTruckC = () => this.totalTruck() * 200;
    totalBusC = () => this.totalBus() * 150;
    getByTime=(tm)=>this.#vehicle.filter(e=> e.date.getTime())


}
// const obj= new ToolManager()
// obj.addCar(new car(123));
// console.log(obj.totalCarC())
