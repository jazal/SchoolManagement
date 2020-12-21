import { SchoolManagementSystemTemplatePage } from './app.po';

describe('SchoolManagementSystem App', function() {
  let page: SchoolManagementSystemTemplatePage;

  beforeEach(() => {
    page = new SchoolManagementSystemTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
