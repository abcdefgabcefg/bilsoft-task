export class Event{
    subscribers: ((...args: any[]) => any)[] = [];
    nofify(...args: any[]): void{
        this.subscribers.forEach(subscriber => subscriber(...args));
    }
    subscribe(subscriber: (...args: any[]) => any){
        this.subscribers.push(subscriber);
    }
}