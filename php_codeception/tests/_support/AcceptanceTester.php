<?php

use Page\LoginPageObject;
use Codeception\Step\Assertion;


/**
 * Inherited Methods
 * @method void wantToTest($text)
 * @method void wantTo($text)
 * @method void execute($callable)
 * @method void expectTo($prediction)
 * @method void expect($prediction)
 * @method void amGoingTo($argumentation)
 * @method void am($role)
 * @method void lookForwardTo($achieveValue)
 * @method void comment($description)
 * @method \Codeception\Lib\Friend haveFriend($name, $actorClass = NULL)
 *
 * @SuppressWarnings(PHPMD)
*/
class AcceptanceTester extends \Codeception\Actor
{
    use _generated\AcceptanceTesterActions;

    private $xlsFile;

    /**
     * @Given I am on :arg1
     */
    public function iAmOn($arg1)
    {
        $this->amOnPage($arg1);
    }

    /**
     * @Given I should see :text
     * @throws Exception
     */
    public function iShouldSee($text)
    {
        $this->waitForText($text);
    }

    /**
     * @Given I fill in :fieldName with :fieldValue
     * @param $fieldName
     * @param $fieldValue
     */
    public function iFillInWith($fieldName, $fieldValue)
    {
        $this->fillField(LoginPageObject::$elements[$fieldName], $fieldValue);
    }

    /**
     * @Given I press search btn
     */
    public function iPressSearchBtn()
    {
       $this->click(LoginPageObject::$elements['searchBtn']);
    }

    /**
     * @Given I click on :arg1
     */
    public function iClickOn($arg1)
    {
        $this->click($arg1);
    }
}
