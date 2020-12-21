import { browser, element, by } from 'protractor';

export class SchoolManagementSystemTemplatePage {
  navigateTo() {
    return browser.get('/');
  }

  getParagraphText() {
    return element(by.css('app-root h1')).getText();
  }
}
