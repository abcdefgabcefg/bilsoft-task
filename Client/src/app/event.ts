export class Event{
    subscribers: (() => any)[] = [];
    nofify(): void{
        this.subscribers.forEach(subscriber => subscriber());
    }
    subscribe(subscriber: () => any){
        this.subscribers.push(subscriber);
    }
}