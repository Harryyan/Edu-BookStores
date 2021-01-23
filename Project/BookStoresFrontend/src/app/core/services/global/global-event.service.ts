import { Injectable ,EventEmitter} from '@angular/core';
import { GlobalEvent } from '../../../models/global-event.model';

@Injectable({
  providedIn: 'root'
})

export class GlobalEventService {
  public langEvent: EventEmitter<GlobalEvent>;

  constructor() {
    this.langEvent = new EventEmitter();
  }

  public languageChanged(lang: string) {
    var event = new GlobalEvent();
    event.type = "lang";
    event.state = lang;
    this.langEvent.emit(event);
  }
}