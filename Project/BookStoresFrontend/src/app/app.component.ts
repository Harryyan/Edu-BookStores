import { Component, OnInit } from '@angular/core';
import { Router, NavigationEnd, ActivatedRoute } from '@angular/router';

import { Title } from '@angular/platform-browser';
import { filter, map, mergeMap } from 'rxjs/operators';

import { PrimeNGConfig } from 'primeng/api';
import { TranslateService } from '@ngx-translate/core';

import { GlobalEventService } from './core/services/global/global-event.service';
import { GlobalEvent } from './models/global-event.model';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent {
  title = 'BookStoresFrontend';

  constructor(private router: Router,
    private titleService: Title,
    private activatedRoute: ActivatedRoute,
    private config: PrimeNGConfig,
    private translateService: TranslateService,
    private globalEventService: GlobalEventService) {}

    ngOnInit() {
      this.translateService.setDefaultLang('en');
      this.globalEventService.langEvent.subscribe((event: GlobalEvent) => {
        if (event.type == "lang") {
          this.translate(event.state);
        }
      });
  
      this.router.events.pipe(
        filter(event => event instanceof NavigationEnd),
        map(() => this.activatedRoute),
        map(route => {
          while (route.firstChild) route = route.firstChild;
          return route;
        }),
        filter(route => route.outlet === 'primary'),
        mergeMap(route => route.data)
      ).subscribe((data) => this.titleService.setTitle(data['title']));
    }
  
    translate(lang: string) {
      this.translateService.use(lang);
      this.translateService.get('primeng').subscribe(res => this.config.setTranslation(res));
    }
}
